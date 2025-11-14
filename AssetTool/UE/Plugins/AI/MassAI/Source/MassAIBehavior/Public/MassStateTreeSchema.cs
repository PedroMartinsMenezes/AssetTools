namespace AssetTool
{
    [JsonAsset("MassStateTreeSchema")]
    public class UMassStateTreeSchema : UStateTreeSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}