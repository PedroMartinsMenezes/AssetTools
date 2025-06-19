namespace AssetTool
{
    [JsonAsset("NiagaraBakerSettings")]
    public class UNiagaraBakerSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}