﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryWithSingleton.Model
{
    public class AutoMobileFactory
    {
        public IAutoMobile Make(AutoOptions autoOptions)
        {
            switch (autoOptions)
            {
                case AutoOptions.BMW:
                    return new BMW();
                case AutoOptions.TESLA:
                    return new Tesla();
                case AutoOptions.AUDI:
                    return new Audi();
                default:
                    throw new ArgumentException($"Invalid auto option: {autoOptions}");
            }
        }
        public sttaic AutoMobileFactory Instance{
            get{
            if(AutoFactoryCoreLib==AutoOptions.)

            }
}
}
