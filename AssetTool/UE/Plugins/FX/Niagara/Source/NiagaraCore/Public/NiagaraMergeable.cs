namespace AssetTool
{
    [JsonAsset("NiagaraMergeable")]
    public class UNiagaraMergeable : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
