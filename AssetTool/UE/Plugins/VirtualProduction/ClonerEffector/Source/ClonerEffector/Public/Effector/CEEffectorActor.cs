namespace AssetTool
{
    [JsonAsset("CEEffectorActor")]
    public class ACEEffectorActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}