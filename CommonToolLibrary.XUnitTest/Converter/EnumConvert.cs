using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.XUnitTest.Converter
{
    using CommonToolLibrary.Common.EnumLibrary;
    using CommonToolLibrary.Extension.Converter;

    using Xunit;

    public class EnumConvert
    {
        [Fact(DisplayName = "枚举转换验证")]
        public void EnumConvertTest()
        {
            Assert.Equal("Divide", MathOperationEnum.Divide.GetKey());
            Assert.Equal(3, MathOperationEnum.Divide.GetValue());
            Assert.Equal("除", MathOperationEnum.Divide.GetDescription());
            Assert.Equal("", MathOperationEnum.Multiply.GetDescription());
            Assert.Equal("无", MathOperationEnum.Multiply.GetDescription("无"));
            Assert.Equal("Multiply", MathOperationEnum.Multiply.GetDescriptionOrKey());
        }
    }
}
