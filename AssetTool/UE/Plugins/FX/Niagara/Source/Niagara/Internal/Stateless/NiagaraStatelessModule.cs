namespace AssetTool
{
    [JsonAsset("NiagaraStatelessModule")]
    public class UNiagaraStatelessModule : UNiagaraMergeable
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}