// SPDX-License-Identifier: MIT

namespace SDL.Events
{
    /// <summary>
    /// The processing state of certain events.
    /// </summary>
    public enum EventProcessingState
    {
        /// <summary>
        /// Will return the current processing state of teh specified event.
        /// </summary>
        Query = -1,

        /// <summary>
        /// Event will be automatically dropped from the event queue and will not be filtered.
        /// </summary>
        Ignore = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        /// <summary>
        /// Event will be automatically dropped from the event queue and will not be filtered.
        /// </summary>
        Disable = 0b_0000_0000_0000_0000_0000_0000_0000_0000,

        /// <summary>
        /// Event will be processed normally.
        /// </summary>
        Enable = 0b_0000_0000_0000_0000_0000_0000_0000_0001
    }
}
