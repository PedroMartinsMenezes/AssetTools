namespace AssetTool
{
    public class FSimpleMemberReference
    {
        public UInt32 MemberParent;
        public FName MemberName;
        public FGuid MemberGuid;

        [Location("operator<<(FArchive& Ar, FSimpleMemberReference& Data)")]
        public FSimpleMemberReference Move(Transfer transfer)
        {
            transfer.Move(ref MemberParent);
            transfer.Move(ref MemberName);
            transfer.Move(ref MemberGuid);
            return this;
        }
    }
}
