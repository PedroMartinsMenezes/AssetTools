namespace AssetTool
{
    [JsonAsset("InstanceDataObjectFixupUndoHandler")]
    public class UInstanceDataObjectFixupUndoHandler : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}