namespace AssetTool
{
    [Location("operator<<(FArchive& Ar, FSimpleMemberReference& Data)")]
    public class FSimpleMemberReference
    {
        public UInt32 MemberParent;
        public FName MemberName;
        public FGuid MemberGuid;
    }

    public static class FSimpleMemberReferenceExt
    {
        public static void Write(this BinaryWriter writer, FSimpleMemberReference item)
        {
            writer.Write(item.MemberParent);
            writer.Write(item.MemberName);
            writer.Write(item.MemberGuid);
        }

        public static FSimpleMemberReference Read(this BinaryReader reader, ref FSimpleMemberReference item)
        {
            item ??= new();
            reader.Read(ref item.MemberParent);
            reader.Read(ref item.MemberName);
            reader.Read(ref item.MemberGuid);
            return item; //83101
        }
    }
}
