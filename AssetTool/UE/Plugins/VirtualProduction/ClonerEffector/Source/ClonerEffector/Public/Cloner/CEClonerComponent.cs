namespace AssetTool
{
    [JsonAsset("CEClonerActor")]
    public class ACEClonerActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
