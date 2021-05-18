using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.Localization;
using Volo.Abp.Localization;
using Volo.Abp.ObjectExtending;

namespace YingHua.Abp.SyncfusionUI.Components.ObjectExtending
{
    public static class EnumHelper
    {
        public static string GetLocalizedMemberName(Type enumType, object value, IStringLocalizerFactory stringLocalizerFactory)
        {
            var memberName = enumType.GetEnumName(value);
            var localizedMemberName = AbpInternalLocalizationHelper.LocalizeWithFallback(
                new[]
                {
                    stringLocalizerFactory.CreateDefaultOrNull()
                },
                new[]
                {
                    $"Enum:{enumType.Name}.{memberName}",
                    $"{enumType.Name}.{memberName}",
                    memberName
                },
                memberName
            );

            return localizedMemberName;
        }
    }
    public static class ObjectExtensionPropertyInfoBlazorExtensions
        {
            private static readonly Type[] DateTimeTypes =
            {
                typeof(DateTime),
                typeof(DateTime?),
                typeof(DateTimeOffset),
                typeof(DateTimeOffset?)
            };

            public static bool IsDate(this IBasicObjectExtensionPropertyInfo property)
            {
                return DateTimeTypes.Contains(property.Type) &&
                       property.GetDataTypeOrNull() == DataType.Date;
            }

            public static bool IsDateTime(this IBasicObjectExtensionPropertyInfo property)
            {
                return DateTimeTypes.Contains(property.Type) &&
                       !property.IsDate();
            }

            public static DataType? GetDataTypeOrNull(this IBasicObjectExtensionPropertyInfo property)
            {
                return property
                    .Attributes
                    .OfType<DataTypeAttribute>()
                    .FirstOrDefault()?.DataType;
            }
        }
    }
