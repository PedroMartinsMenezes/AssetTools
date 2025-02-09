using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssetTool
{
    [TransferibleStruct("Transform", "Transform3f", 195, "Transform3d", 235)]
    public class FTransform3Selector : ITagSelector, ITagConverter //ITransferibleSelector
    {
        public const string StructName = "Transform";

        public string TagName => "Transform";

        public int TagSize => 235;

        #region ITagSelector
        public string GetType(int size)
        {
            return size == 235 ? "Transform3d" : "Transform3f";
        }

        public object GetValue(object value, int size)
        {
            var list = value as List<object>;
            var dict = new Dictionary<string, object>();
            for (int i = 0; i < list.Count - 1; i++)
            {
                var item = list[i] as Dictionary<string, object>;
                var itemKey = item.Keys.First();
                var itemValue = item.Values.First();
                dict.Add(itemKey, itemValue);
            }
            return dict;

        }
        #endregion

        #region ITagConverter
        public object TagRead(object elem)
        {
            var dict = elem.ToObject<Dictionary<string, object>>();
            List<object> list =
            [
                dict.Values.ElementAt(0).ToObject<IJsonConverter>(typeof(FQuat4d)),
                dict.Values.ElementAt(1).ToObject<IJsonConverter>(typeof(FVector3d)),
                dict.Values.ElementAt(2).ToObject<IJsonConverter>(typeof(FVector3d)),
                GlobalObjects.TagNone
            ];
            return list;
        }
        #endregion
    }

    #region Double
    [TransferibleStruct("Transform3d", "Transform", 235)]
    public class FTransform3d : ITransferible, ITagConverter
    {
        public const int SIZE = 235;
        public const string StructName = "Transform3d";

        public FQuat4d Rotation;
        public FVector3d Translation;
        public FVector3d Scale3D;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Transform3d";
        [JsonIgnore]
        public int TagSize
        {
            get
            {
                return 49 + (Rotation is null ? 0 : FQuat4d.SIZE) + (Translation is null ? 0 : FVector3d.SIZE) + (Scale3D is null ? 0 : FVector3d.SIZE) + 8;
            }
        }
        public object TagRead(object elem)
        {
            return elem.ToObject<FTransform3d>();
        }
        #endregion
    }
    #endregion

    #region Float
    [TransferibleStruct("Transform3f", "Transform", 195)]
    public class FTransform3f : ITransferible, IJsonConverter, ITagConverter
    {
        public const int SIZE = 195;
        public const string StructName = "Transform3f";

        public FQuat4f Rotation;
        public FVector3f Translation;
        public FVector3f Scale3D;

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }
        #endregion

        #region IJsonConverter
        public object JsonRead(object value)
        {
            return this;
        }
        public object JsonWrite()
        {
            return this;
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Transform3f";
        [JsonIgnore]
        public int TagSize
        {
            get
            {
                return 49 + (Rotation is null ? 0 : FQuat4f.SIZE) + (Translation is null ? 0 : FVector3f.SIZE) + (Scale3D is null ? 0 : FVector3f.SIZE) + 8;
            }
        }
        public object TagRead(object elem)
        {
            if (elem is JsonElement jelem)
            {
                foreach (var item in jelem.EnumerateObject())
                {
                    if (item.Name.Contains("'Rotation'"))
                    {
                        Rotation = item.Value.ToObject<FQuat4f>();
                    }
                    else if (item.Name.Contains("'Translation'"))
                    {
                        Translation = item.Value.ToObject<FVector3f>();
                    }
                    else if (item.Name.Contains("'Scale3D'"))
                    {
                        Scale3D = item.Value.ToObject<FVector3f>();
                    }
                }
                return this;
            }
            else
            {
                return elem.ToObject<FTransform3f>();
            }
        }
        #endregion
    }
    #endregion

    #region Float or Double
    public class FTransform : ITransferible, IJsonConverter
    {
        public FQuat Rotation;
        public FVector3 Translation;
        public FVector3 Scale3D;

        public ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref Rotation);
            transfer.Move(ref Translation);
            transfer.Move(ref Scale3D);
            return this;
        }

        public object JsonRead(object value)
        {
            return this;
        }

        public object JsonWrite()
        {
            return this;
        }
    }
    #endregion
}
