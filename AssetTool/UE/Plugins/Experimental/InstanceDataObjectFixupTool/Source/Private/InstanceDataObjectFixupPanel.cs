namespace AssetTool
{
    [JsonAsset("InstanceDataObjectFixupUndoHandler")]
    public class UInstanceDataObjectFixupUndoHandler : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}