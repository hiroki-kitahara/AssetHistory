﻿using UnityEngine;
using UnityEngine.Assertions;
using System.Collections.Generic;
using UnityEditor;

namespace AssetHistory
{
	public class Data : ScriptableObject
	{
		public List<string> guids = new List<string>();

		public List<AccessCount> accessCounts = new List<AccessCount>();

		public List<string> recently = new List<string>();

        public List<Filter> filters = new List<Filter>();

		public Mode mode;
	}

	public enum Mode : int
	{
		History,
		Access,
		Recently,
	}

	[System.Serializable]
	public class AccessCount
	{
		public string guid;

		public int accessCount;

		public AccessCount(string path)
		{
			this.guid = path;
			this.accessCount = 1;
		}
	}

    [System.Serializable]
    public class Filter
    {
        public string name;

        public bool valid;

        public Filter(string name)
        {
            this.name = name;
            this.valid = true;
        }
    }
}
