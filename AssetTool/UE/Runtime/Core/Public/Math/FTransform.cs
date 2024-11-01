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
            var rotation = list[0] as Dictionary<string, object>;
            var translation = list[1] as Dictionary<string, object>;
            var scale3D = list[2] as Dictionary<string, object>;
            Dictionary<string, object> dict = new()
            {
                [rotation.Keys.First()] = rotation.Values.First(),
                [translation.Keys.First()] = translation.Values.First(),
                [scale3D.Keys.First()] = scale3D.Values.First(),
            };
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

        public FQuat4d Rotation = new();
        public FVector3d Translation = new();
        public FVector3d Scale3D = new();

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            Rotation.Move(transfer);
            Translation.Move(transfer);
            Scale3D.Move(transfer);
            return this;
        }
        #endregion

        #region ITagConverter
        [JsonIgnore] public string TagName => "Transform3d";
        [JsonIgnore] public int TagSize => 235;
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

        public FQuat4f Rotation = new();
        public FVector3f Translation = new();
        public FVector3f Scale3D = new();

        #region ITransferible
        public ITransferible Move(Transfer transfer)
        {
            Rotation.Move(transfer);
            Translation.Move(transfer);
            Scale3D.Move(transfer);
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
        [JsonIgnore] public int TagSize => 195;
        public object TagRead(object elem)
        {
            return elem.ToObject<FTransform3f>();
        }
        #endregion
    }
    #endregion

    #region Float or Double
    public class FTransform : ITransferible, IJsonConverter
    {
        public FQuat4 Rotation = new();
        public FVector3 Translation = new();
        public FVector3 Scale3D = new();

        public ITransferible Move(Transfer transfer)
        {
            Rotation.Move(transfer);
            Translation.Move(transfer);
            Scale3D.Move(transfer);
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
