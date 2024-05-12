namespace AssetTool
{
    [Location("void UField::Serialize( FArchive& Ar )")]
    public class UField : UObject
    {
        public UInt32 Next;

        public new UField Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!Supports.CustomVer(FFrameworkObjectVersion.Enums.RemoveUField_Next))
            {
                transfer.Move(ref Next);
            }
            return this;
        }
    }
}
