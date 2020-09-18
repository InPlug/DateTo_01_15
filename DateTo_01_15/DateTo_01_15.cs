using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vishnu.Interchange;

namespace DateTo_01_15
{
    /// <summary>
    /// Konvertiert ein übergebenes Datum in den 01. oder 15.
    /// des Datumsmonats, je nach dem ob der Tag des Datums kleiner oder
    /// größer-gleich 15 ist.
    /// </summary>
    /// <remarks>
    /// File: DateTo_01_15.cas
    /// Autor: Erik Nagel
    ///
    /// 24.06.2013 Erik Nagel: erstellt
    /// </remarks>
    public class DateTo_01_15 : IValueModifier
    {
        /// <summary>
        /// Konvertiert ein übergebenes Datum in den 01. oder 15.
        /// des Datumsmonats, je nach dem ob der Tag des Datums kleiner oder
        /// größer-gleich 15 ist.
        /// </summary>
        /// <param name="toConvert">Datum als DateTime.</param>
        /// <returns>DateTime mit Tag 01 oder 15.</returns>
        public object ModifyValue(object toConvert)
        {
            if (toConvert is DateTime)
            {
                if (toConvert != null)
                {
                    DateTime inDateTime = (DateTime)toConvert;
                    return inDateTime.Day < 15 ? inDateTime.AddDays(-inDateTime.Day + 1).Date : inDateTime.AddDays(-inDateTime.Day + 15).Date;
                }
                else
                {
                    return toConvert;
                }
            }
            else
            {
                throw new ArgumentException(String.Format("{0}: kann {1} nicht konvertieren, erwartet wird DateTime", this.GetType().Name, toConvert.ToString()));
            }
        }
    }
}
