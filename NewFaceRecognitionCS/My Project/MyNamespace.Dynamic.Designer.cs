using System;
using System.ComponentModel;
using System.Diagnostics;

namespace NewFaceRecognition.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {

            [EditorBrowsable(EditorBrowsableState.Never)]
            public LOGIN m_LOGIN;

            public LOGIN LOGIN
            {
                [DebuggerHidden]
                get
                {
                    m_LOGIN = Create__Instance__(m_LOGIN);
                    return m_LOGIN;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_LOGIN))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_LOGIN);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public RegisterEmployee m_RegisterEmployee;

            public RegisterEmployee RegisterEmployee
            {
                [DebuggerHidden]
                get
                {
                    m_RegisterEmployee = Create__Instance__(m_RegisterEmployee);
                    return m_RegisterEmployee;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_RegisterEmployee))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_RegisterEmployee);
                }
            }


            [EditorBrowsable(EditorBrowsableState.Never)]
            public TimeInOut m_TimeInOut;

            public TimeInOut TimeInOut
            {
                [DebuggerHidden]
                get
                {
                    m_TimeInOut = Create__Instance__(m_TimeInOut);
                    return m_TimeInOut;
                }
                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_TimeInOut))
                        return;
                    if (value is not null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_TimeInOut);
                }
            }

        }


    }
}