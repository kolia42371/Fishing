﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapEditor.View {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Texts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Texts() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MapEditor.View.Texts", typeof(Texts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Глубина должна быть числом!.
        /// </summary>
        internal static string DeepNeedToBeNumber {
            get {
                return ResourceManager.GetString("DeepNeedToBeNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Введите название водоёма..
        /// </summary>
        internal static string EnterWaterName {
            get {
                return ResourceManager.GetString("EnterWaterName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Количество рыбы должно быть &lt;= 1000.
        /// </summary>
        internal static string FishesCountMustBeLessThanThousand {
            get {
                return ResourceManager.GetString("FishesCountMustBeLessThanThousand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Количество рыбы должно быть числом!.
        /// </summary>
        internal static string FishesCountNeedToBeNumber {
            get {
                return ResourceManager.GetString("FishesCountNeedToBeNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Цена за дом может состоять только из цифр..
        /// </summary>
        internal static string HousePriceNeedToBeNumber {
            get {
                return ResourceManager.GetString("HousePriceNeedToBeNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Минимальная глубина обитания должна быть меньше максимальной!.
        /// </summary>
        internal static string MinDeepNeedToBeLowerThanMax {
            get {
                return ResourceManager.GetString("MinDeepNeedToBeLowerThanMax", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Введите минимальный уровень для доступа..
        /// </summary>
        internal static string MiniumLevel {
            get {
                return ResourceManager.GetString("MiniumLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Цена за день может состоять только из цифр..
        /// </summary>
        internal static string PricePerDayNeedToBeNumber {
            get {
                return ResourceManager.GetString("PricePerDayNeedToBeNumber", resourceCulture);
            }
        }
    }
}
