using System;

namespace CommonToolLibrary.XUnitTest.Cryptography
{
    using System.Collections.Generic;
    using System.Linq;

    using CommonToolLibrary.Extension.CollectionPlus;
    using CommonToolLibrary.Extension.Cryptography;

    using Xunit;

    public class SecretTest
    {
        [Fact(DisplayName = "MD5")]
        public void MD5Test()
        {
            var str = @"2134567890werwtreyrthd,/.,;[]\[\xzvxcb、‘；’sdfdg。、，‘；0978&*（%……%#%@#￥~@！~#@%@!$#%&%^*^&*^&";
            var md5 = MD5Algorithm.Encode(str);
            Assert.NotNull(md5);
        }

        [Fact(DisplayName = "DES")]
        public void DESTest()
        {
            var ss = new List<int>();
            var str = @"2134567890werwtreyrthd,/.,;[]\[\xzvxcb、‘；’sdfdg。、，‘；0978&*（%……%#%@#￥~@！~#@%@!$#%&%^*^&*^&";
            var des = DESAlgorithm.Encode(str);
            var jiemi = DESAlgorithm.Decode(des);
            Assert.Equal(str, jiemi);
            var secretKey = Guid.NewGuid().ToString("N").ToUpperInvariant().Substring(0,16);
            var demo2 = DESAlgorithm.Encode(str, secretKey);
            var demo3 = DESAlgorithm.Decode(demo2);
            var demo4 = DESAlgorithm.Decode(demo2, secretKey);
            Assert.Equal(string.Empty,demo3);
            Assert.Equal(str, demo4);
        }
    }
}
