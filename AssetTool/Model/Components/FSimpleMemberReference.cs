namespace AssetTool
{
    [Location("operator<<(FArchive& Ar, FSimpleMemberReference& Data)")]
    public class FSimpleMemberReference
    {
        public UInt32 MemberParent;
        public FName MemberName;
        public FGuid MemberGuid;
    }
}
