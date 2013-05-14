namespace log4net.Appender
{
    using System.Collections.Generic;
    using Core;
    using Layout;

    public class SmtpAppenderWithSubjectLayout : SmtpAppender
    {
        /// <summary>
        ///     Gets or sets the layout for subject line of the e-mail message.
        /// </summary>
        /// <value>
        ///     The layout for subject line of the e-mail message.
        /// </value>
        /// <remarks>
        ///     <para>
        ///         The layout for subject line of the e-mail message.
        ///     </para>
        /// </remarks>
        public PatternLayout SubjectLayout { get; set; }

        protected override void SendBuffer(LoggingEvent[] events)
        {
            PrepareSubject(events);

            base.SendBuffer(events);
        }

        protected virtual void PrepareSubject(IEnumerable<LoggingEvent> events)
        {
            var subjects = new List<string>();

            foreach (LoggingEvent @event in events)
            {
                if (Evaluator.IsTriggeringEvent(@event))
                    subjects.Add(SubjectLayout.Format(@event));
            }

            Subject = string.Join(", ", subjects.ToArray());
        }
    }
}