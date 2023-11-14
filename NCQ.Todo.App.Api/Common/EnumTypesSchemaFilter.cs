using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.ComponentModel;

namespace NCQ.Todo.App.Api.Common
{
    public class EnumTypesSchemaFilter : ISchemaFilter
    {
        public EnumTypesSchemaFilter()
        {
        }

        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema.Enum != null && schema.Enum.Count > 0 &&
                context.Type != null && context.Type.IsEnum)
            {
                schema.Description += "<p>Members:</p><ul>";

                context.Type.GetFields()
                    .ToList()
                    .ForEach(field =>
                    {
                        if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                        {
                            var value = Convert.ToInt64(Enum.Parse(context.Type, field.Name));
                            schema.Description += $"<li><i>{value}</i> - {attribute.Description.Trim()}</li> ";
                        }
                        else
                        {
                            try
                            {
                                var value = Convert.ToInt64(Enum.Parse(context.Type, field.Name));
                                schema.Description += $"<li><i>{value}</i> - {field.Name.Trim()}</li> ";
                            }
                            catch (Exception)
                            {
                            }
                        }
                    });

                schema.Description += "</ul>";
            }
        }
    }
}
