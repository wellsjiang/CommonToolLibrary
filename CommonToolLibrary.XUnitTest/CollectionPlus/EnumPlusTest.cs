using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.XUnitTest.CollectionPlus
{
    using CommonToolLibrary.Common.EnumLibrary;
    using CommonToolLibrary.Extension.CollectionPlus;
    using CommonToolLibrary.Extension.Converter;

    using Xunit;

    public class EnumPlusTest
    {
        [Fact(DisplayName = "枚举拓展验证")]
        public void EnumTest()
        {
            Assert.True(EnumPlus.ContainKey(typeof(MathOperationEnum),"Multiply"));
            Assert.True(EnumPlus.ContainValue(typeof(MathOperationEnum), MathOperationEnum.Multiply.GetValue()));
            Assert.False(EnumPlus.ContainDescription(typeof(MathOperationEnum), MathOperationEnum.Multiply.GetDescription()));
            Assert.False(EnumPlus.ContainDescription(typeof(MathOperationEnum), MathOperationEnum.Multiply.GetDescription("无")));
            Assert.True(EnumPlus.ContainDescription(typeof(MathOperationEnum), MathOperationEnum.Plus.GetDescription()));
            byte demo1 = 1;
            byte demo2 = 9;
            Assert.Equal("Plus", EnumPlus.GetKey(typeof(MathOperationEnum), demo1));
            Assert.Equal("", EnumPlus.GetKey(typeof(MathOperationEnum), demo2));
            Assert.Equal("无", EnumPlus.GetKey(typeof(MathOperationEnum), demo2,"无"));
            Assert.Equal("加", EnumPlus.GetDescription(typeof(MathOperationEnum), demo1));
            Assert.Equal("", EnumPlus.GetDescription(typeof(MathOperationEnum), demo2));
            Assert.Equal("无", EnumPlus.GetDescription(typeof(MathOperationEnum), demo2, "无"));
            Assert.Equal("", EnumPlus.GetDescription(typeof(MathOperationEnum), MathOperationEnum.Multiply.GetValue(), ""));
            Assert.Equal("无", EnumPlus.GetDescription(typeof(MathOperationEnum), MathOperationEnum.Multiply.GetValue(), "无"));
            Assert.Equal(new Dictionary<string,int>
            {
                { "Minus", 0},{ "Plus", 1},{ "Multiply", 2},{ "Divide", 3}
            },EnumPlus.GetKeyValue(typeof(MathOperationEnum)));
            Assert.Equal(new Dictionary<int, string>
            {
                {0, "Minus"},{ 1,"Plus"},{ 2,"Multiply"},{ 3,"Divide"}
            }, EnumPlus.GetValueKey(typeof(MathOperationEnum)));
            Assert.Equal(new Dictionary<string, string>
            {
                { "Minus", "减"},{ "Plus", "加"},{ "Multiply", ""},{ "Divide", "除"}
            }, EnumPlus.GetKeyDescription(typeof(MathOperationEnum)));
            Assert.Equal(new Dictionary<string, string>
            {
                { "Minus", "减"},{ "Plus", "加"},{ "Multiply", "无"},{ "Divide", "除"}
            }, EnumPlus.GetKeyDescription(typeof(MathOperationEnum),"无"));
            Assert.Equal(new Dictionary<int, string>
            {
                {0, "减"},{ 1,"加"},{ 2,""},{ 3,"除"}
            }, EnumPlus.GetValueDescription(typeof(MathOperationEnum)));
            Assert.Equal(new Dictionary<int, string>
            {
                {0, "减"},{ 1,"加"},{ 2,"无"},{ 3,"除"}
            }, EnumPlus.GetValueDescription(typeof(MathOperationEnum),"无"));
            var listDemo=new List<string>{"1","2","4","5"};
            listDemo.Foreach((x,index)=>{

            });
        }
    }
}
