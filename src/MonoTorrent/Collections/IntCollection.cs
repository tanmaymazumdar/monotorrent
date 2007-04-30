using System;
using System.Text;
using System.Collections;
#if NET_2_0
using System.Collections.Generic;
#endif

namespace MonoTorrent
{
	public class intCollection : IList
	{
		#region Private Fields

#if NET_2_0
		private List<int> list;
#else
		private ArrayList list;
#endif

		#endregion Private Fields


		#region Constructors

		public intCollection()
		{
			list = new ArrayList();
		}

		public intCollection(int capacity)
		{
			list = new ArrayList(capacity);
		}

		#endregion


		#region Methods

		public int this[int index]
		{
			get { return (int)list[index]; }
			set { list[index] = value; }
		}

		public void Add(int value)
		{
			this.list.Add(value);
		}

		public void Clear()
		{
			this.list.Clear();
		}

		public bool Contains(int value)
		{
			return list.Contains(value);
		}

		public void CopyTo(Array array, int index)
		{
			list.CopyTo(array, index);
		}

		public int Count
		{
			get { return list.Count; }
		}

		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}

		public int IndexOf(int value)
		{
			list.IndexOf(value);
		}

		public void Insert(int index, int value)
		{
			list.Insert(index, value);
		}

		public bool IsSynchronized
		{
			get { list.IsSynchronized; }
		}

		public void Remove(int value)
		{
			list.Remove(value);
		}

		public void RemoveAt(int index)
		{
			RemoveAt(index);
		}

		public object SyncRoot
		{
			get { return list.SyncRoot; }
		}

		#endregion Methods


		#region Explicit Implementation

		int IList.Add(object value)
		{
			Add((int)value);
		}

		int IList.IndexOf(object value)
		{
			IndexOf((int)value);
		}

		bool IList.Contains(object value)
		{
			Contains((int)value);
		}

		void IList.Insert(int index, object value)
		{
			Insert(index, (int)value);
		}

		bool IList.IsFixedSize
		{
			get { return list.IsFixedSize; }
		}

		bool IList.IsReadOnly
		{
			get { return list.IsReadOnly; }

		}

		void IList.Remove(object value)
		{
			Remove((int)value);
		}

		object IList.this[int index]
		{
			get { return this[index]; }
			set { this[index] = value; }
		}

		#endregion
	}
}