namespace AssetTool
{
    [JsonAsset("NiagaraStatelessModule")]
    public class UNiagaraStatelessModule : UNiagaraMergeable
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}