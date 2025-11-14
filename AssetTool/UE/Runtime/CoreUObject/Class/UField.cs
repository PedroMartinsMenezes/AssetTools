namespace AssetTool
{
    [JsonAsset("Field")]
    public class UField : UObject
    {
        public UInt32 Next;

        [Location("void UField::Serialize( FArchive& Ar )")]
        public override ITransferable Move(Transfer transfer)
        {
            base.Move(transfer);
            if (!transfer.Supports.RemoveUField_Next)
            {
                transfer.Move(ref Next);
            }
            return this;
        }
    }
}
