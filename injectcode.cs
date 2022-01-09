UnityEngine.Debug.Log("Hello, World!!");
		try
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			for (int i = 0; i < types.Length; i++)
			{
				FieldInfo[] fields = types[i].GetFields();
				for (int j = 0; j < fields.Length; j++)
				{
					UnityEngine.Debug.Log(fields[j].Name);
				}
			}
		}
