﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CadeMeuPet.Extensions
{
    public static class ModelStateExtension
    {
        public static List<string> GetErros(this ModelStateDictionary modelState)
        {
            var result = new List<string>();

            foreach (var item in modelState.Values)
            {
                foreach (var error in item.Errors)
                {
                    result.Add(error.ErrorMessage);
                }
            }

            return result;
        }
    }
}
