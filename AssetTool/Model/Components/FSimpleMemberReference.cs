using System.ComponentModel;

namespace AssetTool
{
    [Description("FORCEINLINE FArchive& operator<<(FArchive& Ar, FSimpleMemberReference& Data)")]
    public class FSimpleMemberReference
    {
        public UInt32 MemberParent; //Confirmar tipo
        public FName MemberName;
        public FGuid MemberGuid;
    }
}
