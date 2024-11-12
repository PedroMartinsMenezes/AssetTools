namespace AssetTool
{
    [JsonAsset("NiagaraMergeable")]
    public class UNiagaraMergeable : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}
