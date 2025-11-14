namespace AssetTool
{
    [JsonAsset("MassSpawner")]
    public class AMassSpawner : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}