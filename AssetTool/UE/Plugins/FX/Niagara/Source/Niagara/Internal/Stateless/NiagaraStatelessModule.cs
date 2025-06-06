namespace AssetTool
{
    [JsonAsset("NiagaraStatelessModule")]
    public class UNiagaraStatelessModule : UNiagaraMergeable
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}