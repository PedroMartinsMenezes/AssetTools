namespace AssetTool
{
    [Location("void UField::Serialize( FArchive& Ar )")]
    [JsonAsset("Field")]
    public class UField : UObject
    {
        public UInt32 Next;

        public override UObject Move(Transfer transfer)
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
