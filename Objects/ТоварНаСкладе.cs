﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.АСУ_Склад
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Товар на складе.
    /// </summary>
    // *** Start programmer edit section *** (ТоварНаСкладе CustomAttributes)

    // *** End programmer edit section *** (ТоварНаСкладе CustomAttributes)
    [AutoAltered()]
    [Caption("Товар на складе")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТоварНаСкладеE", new string[] {
            "Количество as \'Количество\'",
            "Товар as \'Товар\'",
            "Товар.Название as \'Название\'"}, Hidden=new string[] {
            "Товар.Название"})]
    [MasterViewDefineAttribute("ТоварНаСкладеE", "Товар", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    public class ТоварНаСкладе : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private IIS.АСУ_Склад.Товар fТовар;
        
        private IIS.АСУ_Склад.Склад fСклад;
        
        // *** Start programmer edit section *** (ТоварНаСкладе CustomMembers)

        // *** End programmer edit section *** (ТоварНаСкладе CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (ТоварНаСкладе.Количество CustomAttributes)

        // *** End programmer edit section *** (ТоварНаСкладе.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (ТоварНаСкладе.Количество Get start)

                // *** End programmer edit section *** (ТоварНаСкладе.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (ТоварНаСкладе.Количество Get end)

                // *** End programmer edit section *** (ТоварНаСкладе.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТоварНаСкладе.Количество Set start)

                // *** End programmer edit section *** (ТоварНаСкладе.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (ТоварНаСкладе.Количество Set end)

                // *** End programmer edit section *** (ТоварНаСкладе.Количество Set end)
            }
        }
        
        /// <summary>
        /// Товар на складе.
        /// </summary>
        // *** Start programmer edit section *** (ТоварНаСкладе.Товар CustomAttributes)

        // *** End programmer edit section *** (ТоварНаСкладе.Товар CustomAttributes)
        [PropertyStorage(new string[] {
                "Товар"})]
        [NotNull()]
        public virtual IIS.АСУ_Склад.Товар Товар
        {
            get
            {
                // *** Start programmer edit section *** (ТоварНаСкладе.Товар Get start)

                // *** End programmer edit section *** (ТоварНаСкладе.Товар Get start)
                IIS.АСУ_Склад.Товар result = this.fТовар;
                // *** Start programmer edit section *** (ТоварНаСкладе.Товар Get end)

                // *** End programmer edit section *** (ТоварНаСкладе.Товар Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТоварНаСкладе.Товар Set start)

                // *** End programmer edit section *** (ТоварНаСкладе.Товар Set start)
                this.fТовар = value;
                // *** Start programmer edit section *** (ТоварНаСкладе.Товар Set end)

                // *** End programmer edit section *** (ТоварНаСкладе.Товар Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.АСУ_Склад.Склад.
        /// </summary>
        // *** Start programmer edit section *** (ТоварНаСкладе.Склад CustomAttributes)

        // *** End programmer edit section *** (ТоварНаСкладе.Склад CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "Склад"})]
        public virtual IIS.АСУ_Склад.Склад Склад
        {
            get
            {
                // *** Start programmer edit section *** (ТоварНаСкладе.Склад Get start)

                // *** End programmer edit section *** (ТоварНаСкладе.Склад Get start)
                IIS.АСУ_Склад.Склад result = this.fСклад;
                // *** Start programmer edit section *** (ТоварНаСкладе.Склад Get end)

                // *** End programmer edit section *** (ТоварНаСкладе.Склад Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ТоварНаСкладе.Склад Set start)

                // *** End programmer edit section *** (ТоварНаСкладе.Склад Set start)
                this.fСклад = value;
                // *** Start programmer edit section *** (ТоварНаСкладе.Склад Set end)

                // *** End programmer edit section *** (ТоварНаСкладе.Склад Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТоварНаСкладеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварНаСкладеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварНаСкладеE", typeof(IIS.АСУ_Склад.ТоварНаСкладе));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ТоварНаСкладе.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfТоварНаСкладе CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfТоварНаСкладе CustomAttributes)
    public class DetailArrayOfТоварНаСкладе : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.АСУ_Склад.DetailArrayOfТоварНаСкладе members)

        // *** End programmer edit section *** (IIS.АСУ_Склад.DetailArrayOfТоварНаСкладе members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ТоварНаСкладе by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ТоварНаСкладе.
        /// </summary>
        public DetailArrayOfТоварНаСкладе(IIS.АСУ_Склад.Склад fСклад) : 
                base(typeof(ТоварНаСкладе), ((ICSSoft.STORMNET.DataObject)(fСклад)))
        {
        }
        
        public IIS.АСУ_Склад.ТоварНаСкладе this[int index]
        {
            get
            {
                return ((IIS.АСУ_Склад.ТоварНаСкладе)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.АСУ_Склад.ТоварНаСкладе dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
