using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace EmployeeAttendanceTracking.Lists
{
    class AccessLogQueue<T>
    {
        private readonly object lockObject = new object();
        private readonly Queue<T> items = new Queue<T>();

        public void Push(T item)
        {
            lock (lockObject)
            {
                items.Enqueue(item);
            }
        }

        public T Pop()
        {
            lock (lockObject)
            {
                if (items.Count == 0)
                    throw new InvalidOperationException("Queue is empty");

                return items.Dequeue();
            }
        }

        public BindingList<T> GetAll()
        {
            lock (lockObject)
            {
                return new BindingList<T>(items.ToList());
            }
        }
    }
}