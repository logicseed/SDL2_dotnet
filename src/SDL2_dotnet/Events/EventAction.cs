// SPDX-License-Identifier: MIT

namespace SDL.Events
{
    /// <summary>
    /// Action to perform when working with the event queue.
    /// </summary>
    public enum EventAction : byte
    {
        /// <summary>
        /// Add an event to the queue.
        /// </summary>
        AddEvent = 0b_0000_0000,

        /// <summary>
        /// Get one or more event from the queue without removing them from the queue.
        /// </summary>
        PeekEvent = 0b_0000_0001,

        /// <summary>
        /// Get one or more events from the queue and remove them from the queue.
        /// </summary>
        GetEvent = 0b_0000_0010
    }
}
