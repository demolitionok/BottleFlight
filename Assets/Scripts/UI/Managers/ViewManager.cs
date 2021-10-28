using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ViewManager : IViewManager
{
    private readonly View[] _views;
    private readonly Stack<View> _history;
    private View _currentView;

    public ViewManager(View startingView, View[] views)
    {
        _views = views;
        _history = new Stack<View>();

        foreach (var view in _views)
        {
            view.Init();
            view.Hide();
        }

        ShowView(startingView);
    }

    private T GetView<T>() where T : View
    {
        foreach (var view in _views)
        {
            if (view is T viewT)
            {
                return viewT;
            }
        }
        Debug.Log($"Corresponding view was not found: {typeof(T)}");
        return null;
    }
    
    private void ShowView(View viewToShow, bool remember = true)
    {
        if (_currentView != null)
        {
            if (remember)
            {
                _history.Push(_currentView);
            }
            _currentView.Hide();
        }
        _currentView = viewToShow;
        if(viewToShow != null)
            viewToShow.Show();
    }

    public void ShowView<T>(bool remember = true) where T : View => ShowView(GetView<T>(), remember);

    public void ShowLast() => ShowView(_history.Pop(),false);
}
