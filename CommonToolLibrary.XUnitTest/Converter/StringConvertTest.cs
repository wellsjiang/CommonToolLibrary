using CommonToolLibrary.Extension.Converter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CommonToolLibrary.XUnitTest.Converter
{
    using CommonToolLibrary.Common.EnumLibrary;

    public class StringConvertTest
    {
        [Fact(DisplayName ="字符串转int")]
        public void ToInt()
        {
            Assert.Equal(0, "测试字符串".ToInt());
            Assert.Equal(-2147483647, "-2147483647".ToInt());
            Assert.Equal(0, "-2147483649".ToInt());
            Assert.Equal(-2147483646, "-2147483646.9".ToInt());
            Assert.Equal(2147483647, "+2147483647".ToInt());
            Assert.Equal(0, "+2147483649".ToInt());
            Assert.Equal(2147483646, "+2147483646.9".ToInt());
            Assert.Equal(21, "21.474836469".ToInt());
            Assert.Equal(2, "343.5656.78".ToInt(2));
            Assert.Equal(0, "04ty78".ToInt());
            Assert.Equal(0, "0".ToInt());
            Assert.Equal(90, "00090".ToInt(1));
            Assert.Equal(0, "00.0009".ToInt());
            Assert.Equal(6, "006.000".ToInt());
            Assert.Equal(9, "009.6000".ToInt());
            Assert.Equal(2, "009.6000".ToInt(2,false));
            Assert.Equal(2, "000.0000".ToInt(2, false));
            Assert.Equal(0, "000.0000".ToInt(2));
            Assert.Equal(new DateTime(1900,1,1), "1900-1-1".ToDateTime(DateTime.MinValue));
            Assert.Equal(DateTime.MinValue, "1900-1-1 546757".ToDateTime(DateTime.MinValue));
            
        }

        [Fact(DisplayName = "字符串转bool")]
        public void ToBool()
        {
            Assert.Equal(true,"是".ToBool());
            Assert.Equal(false, "否".ToBool());
            Assert.Equal(true, "1".ToBool());
            Assert.Equal(false, "0".ToBool());
            Assert.Equal(true, "true".ToBool());
            Assert.Equal(false, "fasle".ToBool());
            Assert.Equal(true, "True".ToBool());
            Assert.Equal(false, "Fasle".ToBool());
            Assert.Equal(false, "假".ToBool(true));
            Assert.Equal(false, "假".ToBool());
            Assert.Equal(false, "测试".ToBool());
            Assert.Equal(true, "测试".ToBool(true));
        }

        [Fact(DisplayName = "字符串base64互转")]
        public void Base64Test()
        {
            var source = "我就是蒋家伟wellsjiang@1234567890~！@#￥%……*（）——+@#$%%^^，。、在v,./";
            var base64 = source.ToBase64();
            var result = base64.FromBase64();
            Assert.Equal(source, result);
            Assert.Equal(source, source.FromBase64());
            Assert.Equal("", source.FromBase64(Base64ConvertFaildDefalut.Empty));
            Assert.Equal(null, source.FromBase64(Base64ConvertFaildDefalut.Null));
        }
    }
}

