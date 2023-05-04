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
        /// <summary>
        /// Add new item to the Queue
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            lock (lockObject)
            {
                items.Enqueue(item);
            }
        }
        /// <summary>
        /// Remove new item from the Queue
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            lock (lockObject)
            {
                if (items.Count == 0)
                    throw new InvalidOperationException("Queue is empty");

                return items.Dequeue();
            }
        }
        /// <summary>
        /// Get all data for listing
        /// </summary>
        /// <returns></returns>
        public BindingList<T> GetAll()
        {
            lock (lockObject)
            {
                return new BindingList<T>(items.ToList());
            }
        }
    }
}