using System.Diagnostics;
using System.Text.Json;

namespace AssetTool
{
    //[TransferibleStruct("Transform")]
    public class FTransform3ElegantJson : ITagConverter, IValueConverter
    {
        public object TagToDerived
            (object value, int size)
        {
            var dict = value as Dictionary<string, object>;
            for (int i = 0; i < dict.Count - 1; i++)
            {
                if (dict.ElementAt(i).Value is FPropertyTag propertyTag)
                {
                    var itemKey = BasePropertyJson.BuildKey(propertyTag.StructName.Value, propertyTag);
                    var itemValue = propertyTag.Value;
                    dict.Add(itemKey, itemValue);
                }
            }
            return dict;

        }

        public object DerivedToTag(object elem, Transfer transfer)
        {
            var dict = elem.ToObject<Dictionary<string, object>>(transfer);
            List<object> list =
            [
                dict.Values.ElementAt(0).ToObject<FQuat4d>(transfer),
                dict.Values.ElementAt(1).ToObject<FVector3d>(transfer),
                dict.Values.ElementAt(2).ToObject<FVector3d>(transfer),
                new FPropertyTag { Name = transfer.GlobalNames.None }
            ];
            return list;
        }
    }

    #region Double
    //[TransferibleStruct("Transform3d", "Transform", 235)]
    public class FTransform3d : ITransferible, ITagConverter, IDynamicSize
    {
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
        public int TagSize(Transfer transfer) => FPropertyTag.StructHeaderSize(transfer) + (Rotation.IsZero() ? 0 : FQuat4d.SIZE) + (Translation.IsZero() ? 0 : FVector3d.SIZE) + (Scale3D.IsZero() ? 0 : FVector3d.SIZE) + 8;
        public object DerivedToTag(object elem, Transfer transfer)
        {
            return elem.ToObject<FTransform3d>(transfer);
        }
        #endregion
    }
    #endregion

    #region Float
    [DebuggerDisplay("R{Rotation} T{Translation} S{Scale3D}")]
    public class FTransform3f : ITransferible, ITagConverter, IDynamicSize
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

        #region ITagConverter
        public int TagSize(Transfer transfer) => FPropertyTag.StructHeaderSize(transfer) + (Rotation.IsZero() ? 0 : FQuat4f.SIZE) + (Translation.IsZero() ? 0 : FVector3f.SIZE) + (Scale3D.IsZero() ? 0 : FVector3f.SIZE) + 8;
        public object DerivedToTag(object elem, Transfer transfer)
        {
            if (elem is JsonElement jelem)
            {
                foreach (var item in jelem.EnumerateObject())
                {
                    if (item.Name.Contains("'Rotation'"))
                    {
                        Rotation = item.Value.ToObject<FQuat4f>(transfer);
                    }
                    else if (item.Name.Contains("'Translation'"))
                    {
                        Translation = item.Value.ToObject<FVector3f>(transfer);
                    }
                    else if (item.Name.Contains("'Scale3D'"))
                    {
                        Scale3D = item.Value.ToObject<FVector3f>(transfer);
                    }
                }
                return this;
            }
            else
            {
                return elem.ToObject<FTransform3f>(transfer);
            }
        }
        #endregion
    }
    #endregion

    #region Float or Double
    public class FTransform : ITransferible
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
    }
    #endregion
}
