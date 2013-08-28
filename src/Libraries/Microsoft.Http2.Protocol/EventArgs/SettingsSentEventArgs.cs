﻿using SharedProtocol.Framing;

namespace SharedProtocol.EventArgs
{
    /// <summary>
    /// This class is designed for future usage
    /// </summary>
    internal class SettingsSentEventArgs : System.EventArgs
    {
        public SettingsFrame SettingsFrame { get; private set; }
        
        public SettingsSentEventArgs(SettingsFrame frame)
        {
            SettingsFrame = frame;
        }
    }
}
