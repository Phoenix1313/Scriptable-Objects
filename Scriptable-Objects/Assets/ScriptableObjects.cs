using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjects : ScriptableObject
{
    private List<GameEventListener> listeners =
        new list<GameEventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
            listeners[i].OnEventRaised();
    }

    public void RegisterListener(GameEventListener listener)
    { listeners.Remove(listener); }

}
