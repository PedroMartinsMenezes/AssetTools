namespace AssetTool
{
    public class FRigVMVariant : ITransferable
    {
        public FGuid Guid;
        public List<FRigVMTag> Tags;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMVariant& Data)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Guid);
            transfer.Move(ref Tags);
            return this;
        }
    }

    public class FRigVMTag : ITransferable
    {
        public FName Name;
        public FString Label;
        public FText ToolTip;
        public FLinearColor Color;
        public FBool bShowInUserInterface;
        public FBool bMarksSubjectAsInvalid;

        [Location("friend FArchive& operator<<(FArchive& Ar, FRigVMTag& Data)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref Name);
            transfer.Move(ref Label);
            transfer.Move(ref ToolTip);
            transfer.Move(ref Color);
            transfer.Move(ref bShowInUserInterface);
            transfer.Move(ref bMarksSubjectAsInvalid);
            return this;
        }
    }
}
