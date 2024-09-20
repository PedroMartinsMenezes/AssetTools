using System.Globalization;
using System.Text.RegularExpressions;

namespace AssetTool
{
    public static class FTransform3Selector
    {
        public const string StructName = "Transform";

        public static object Move(Transfer transfer, int num, object value)
        {
            return GlobalObjects.Transfer.MoveTags(value.ToObject<List<object>>(), 0, null);
        }
        public static object GetDerived(FPropertyTag tag)
        {
            return tag.Size == FTransform3f.SIZE ? new FTransform3fJson(tag) : new FTransform3dJson(tag);
        }
    }

    #region Double
    public class FTransform3d
    {
        public const int SIZE = 235;
        public const string StructName = "Transform3d";

        public FQuat4d Rotation = new();
        public FVector3d Translation = new();
        public FVector3d Scale3D = new();

        public FTransform3d() { }

        public virtual FTransform3d Move(Transfer transfer)
        {
            Rotation.Move(transfer);
            Translation.Move(transfer);
            Scale3D.Move(transfer);
            return this;
        }
    }

    public class FTransform3dJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Transform3d '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FTransform3dJson() { }

        public FTransform3dJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";

            var list = tag.Value as List<object>;

            var rotation = list[0] as FQuat4dJson;
            var translation = list[1] as FVector3dJson;
            var scale3D = list[2] as FVector3dJson;

            Dictionary<string, object> value = new()
            {
                [rotation.Keys.First()] = rotation.Values.First(),
                [translation.Keys.First()] = translation.Values.First(),
                [scale3D.Keys.First()] = scale3D.Values.First(),
            };

            Add($"Transform3d '{tag.Name.ToString()}'{arrayIndex}{guidValue}", value);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), Values.First() as Dictionary<string, object>);
        }

        public static FPropertyTag GetNative(string key, Dictionary<string, object> value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;

            var rotation = FQuat4dJson.GetNative(value.Keys.ElementAt(0), value.Values.ElementAt(0).ToString());
            var translation = FVector3dJson.GetNative(value.Keys.ElementAt(1), value.Values.ElementAt(1).ToString());
            var scale3D = FVector3dJson.GetNative(value.Keys.ElementAt(2), value.Values.ElementAt(2).ToString());

            List<object> list = [rotation, translation, scale3D, GlobalObjects.TagNone];

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FTransform3Selector.StructName),
                Value = list,
                Size = FTransform3d.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
    #endregion

    #region Float
    public class FTransform3f
    {
        public const int SIZE = FQuat4f.SIZE + FVector3f.SIZE + FVector3f.SIZE;
        public const string StructName = "Transform3f";

        public FQuat4f Rotation = new();
        public FVector3f Translation = new();
        public FVector3f Scale3D = new();

        public FTransform3f() { }

        public virtual FTransform3f Move(Transfer transfer)
        {
            Rotation.Move(transfer);
            Translation.Move(transfer);
            Scale3D.Move(transfer);
            return this;
        }
    }

    public class FTransform3fJson : Dictionary<string, object>, IPropertytag
    {
        public const string Pattern = "Transform3f '(.*)'\\s*(?:\\[(\\d+)\\])?\\s*(?:\\(([-a-fA-F0-9]+)\\))?";

        public FTransform3fJson() { }

        public FTransform3fJson(FPropertyTag tag)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            string arrayIndex = tag.ArrayIndex > 0 ? $"[{tag.ArrayIndex}]" : string.Empty;
            string guidValue = tag.HasPropertyGuid == 0 ? string.Empty : $" ({tag.GuidValue})";
            var value = tag.Value as FTransform3f;
            Add($"Transform3f '{tag.Name.ToString()}'{arrayIndex}{guidValue}", value);
        }

        public FPropertyTag GetNative()
        {
            return GetNative(Keys.First(), Values.First() as FTransform3f);
        }

        public static FPropertyTag GetNative(string key, FTransform3f value)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            var match = Regex.Match(key, Pattern);
            string name = match.Groups[1].Value;
            string index = match.Groups[2].Value;
            string guid = match.Groups[3].Value;

            return new FPropertyTag
            {
                Name = new FName(name),
                Type = new FName(FStructProperty.TYPE_NAME),
                StructName = new FName(FTransform3Selector.StructName),
                Value = value,
                Size = FTransform3f.SIZE,
                ArrayIndex = index.Length > 0 ? int.Parse(index) : 0,
                HasPropertyGuid = (byte)(guid.Length > 0 ? 1 : 0),
                PropertyGuid = guid.Length > 0 ? new FGuid(guid) : null,
            };
        }
    }
    #endregion
}
