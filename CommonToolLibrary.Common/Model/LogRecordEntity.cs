using System;
using System.Collections.Generic;
using System.Text;

namespace CommonToolLibrary.Common.Model
{
    using CommonToolLibrary.Common.EnumLibrary;

    public sealed class LogRecordEntity
    {
        private LogRecordEntity() { }

        public LogRecordEntity(LogRecordType logType = LogRecordType.Normal)
        {
            LogType = logType;
        }

        #region public

        /// <summary>
        /// 日志类型
        /// </summary>
        public LogRecordType LogType { get; set; }

        /// <summary>
        /// 日志信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 耗时
        /// </summary>
        public long ElapsedTime { get; set; }

        /// <summary>
        /// 异常信息
        /// </summary>
        public Exception Exception { get; set; }

        #endregion

        #region internal

        /// <summary>
        /// 程序集
        /// </summary>
        public string AssemblyName { get; internal set; }

        /// <summary>
        /// 名称空间
        /// </summary>
        public string Namespace { get; internal set; }

        /// <summary>
        /// 类名
        /// </summary>
        public string Class { get; internal set; }

        /// <summary>
        /// 方法名
        /// </summary>
        public string Method { get; internal set; }

        /// <summary>
        /// 部署IP
        /// </summary>
        public string DeployIp { get; internal set; }

        /// <summary>
        /// 调用时间
        /// </summary>
        public DateTime InvokeTime { get; internal set; }

        /// <summary>
        /// 日志容量大小
        /// </summary>
        public int LogSize { get; internal set; }

        /// <summary>
        /// 跟踪Id，跨站唯一
        /// </summary>
        public long TraceId { get; set; }

        #endregion
    }
}
