using Bookbase.Application.Exceptions;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Bookbase.Attributes
{
    public class ValidateDtoAttribute : Attribute, IAsyncActionFilter
    {
        private readonly Type _dtoType;

        public ValidateDtoAttribute(Type dtoType)
        {
            _dtoType = dtoType;
        }


        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            var modelState = context.ModelState;

            if (!modelState.IsValid)
            {
                return;
            }

            var dto = context.ActionArguments.Values.FirstOrDefault(x => x?.GetType() == _dtoType);

            if (dto != null)
            {
                var validatorType = typeof(IValidator<>).MakeGenericType(_dtoType);
                var validator = context.HttpContext.RequestServices.GetService(validatorType) as IValidator;

                var validationResult = await validator.ValidateAsync(new ValidationContext<object>(dto));

                if (!validationResult.IsValid)
                {
                    throw new BadRequestException(validationResult.ToString())
                    {
                        ErrorCode = "001"
                    };
                }
            }

            await next();
        }
    }
}
