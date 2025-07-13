namespace AssetTool
{
    [JsonAsset("MassSpawner")]
    public class AMassSpawner : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}