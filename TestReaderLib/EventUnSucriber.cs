using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

public static class EventUnsubscriber
{
    // Method to automatically find and unsubscribe all event handlers of a form/control
    public static void UnsubscribeAllEvents(Control control)
    {
        // Recursively unsubscribe events for all child controls
        foreach (Control childControl in control.Controls)
        {
            UnsubscribeAllEvents(childControl);
        }

        // Unsubscribe events for the current control
        UnsubscribeControlEvents(control);
    }

    private static void UnsubscribeControlEvents(Control control)
    {
        // Get the field that holds the EventHandlerList for the control
        FieldInfo eventHandlerField = typeof(Control).GetField("Events", BindingFlags.NonPublic | BindingFlags.Instance);
        if (eventHandlerField != null)
        {
            // Retrieve the EventHandlerList for this control
            EventHandlerList eventHandlerList = eventHandlerField.GetValue(control) as EventHandlerList;
            if (eventHandlerList == null) return;

            // Get the internal method to clear all events
            MethodInfo removeHandlerMethod = typeof(EventHandlerList).GetMethod("RemoveHandler", BindingFlags.Instance | BindingFlags.NonPublic);

            // Get the events from the control class (all events)
            FieldInfo[] events = typeof(Control).GetFields(BindingFlags.NonPublic | BindingFlags.Static);
            foreach (FieldInfo eventField in events)
            {
                object eventKey = eventField.GetValue(control);
                if (eventKey != null && removeHandlerMethod != null)
                {
                    // Remove the event handler
                    removeHandlerMethod.Invoke(eventHandlerList, new object[] { eventKey, null });
                }
            }
        }
    }
}
