using UnityEngine.EventSystems;

namespace TFTools.Extensions
{
    public static partial class Extensions_EventTrigger
    {
        /// <summary>
        /// Shorcut for adding a delegate to a eventTrigger event.
        /// </summary>
        public static void AddDelegate (this EventTrigger _eventTrigger, EventTriggerType _eventTriggerType, UnityEngine.Events.UnityAction<BaseEventData> _delegate)
        {
            EventTrigger.Entry entry = new EventTrigger.Entry ();
            entry.eventID = _eventTriggerType;
            entry.callback.AddListener (_delegate);
            _eventTrigger.triggers.Add (entry);
        }
    }
}