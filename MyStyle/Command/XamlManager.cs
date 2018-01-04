using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace MyStyle.Command
{
    public class XamlManager
    {
        public Dictionary<Type, Uri> DictionaryXaml = new Dictionary<Type, Uri>();

        private static XamlManager instance = null;
        private static object objLock = new object();
        public static XamlManager GetInstance()
        {
            if (instance == null)
            {
                lock (objLock)
                {
                    if (instance == null) instance = new XamlManager();
                }
            }
            return instance;
        }

        public bool RegisteredXaml(Type type, Uri uri)
        {
            try
            {
                if (IsXamlExist(type)) return false;
                instance.DictionaryXaml.Add(type, uri);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool UnregisteredXaml(Type type)
        {
            try
            {
                if (!IsXamlExist(type)) return false;
                instance.DictionaryXaml.Remove(type);

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool EditXaml(Type type, Uri uri)
        {
            try
            {
                if (IsXamlExist(type)) return false;
                instance.DictionaryXaml[type] = uri;

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool IsXamlExist(Type type)
        {
            return instance.DictionaryXaml.ContainsKey(type);
        }

        public Stream GetXamlStream(Type type)
        {
            Stream Result = null;
            try
            {
                if (IsXamlExist(type))
                {
                    Result = Application.GetResourceStream(instance.DictionaryXaml[type]).Stream;
                }
            }
            catch (Exception ex)
            {
            }
            return Result;
        }

        public T GetNewObject<T>() where T: FrameworkElement, new()
        {
            T Result = null;
            try
            {
                if (instance.DictionaryXaml.ContainsKey(typeof(T)))
                {
                    using (Stream stream = GetXamlStream(typeof(T)))
                    {
                        object root = System.Windows.Markup.XamlReader.Load(stream);
                        Result = (T)root;
                        Result.ReConnectVariables();
                    }
                }
                else
                {
                    Result = new T();
                }
            }
            catch (Exception ex)
            {

            }
            return Result;

        }
    }
}