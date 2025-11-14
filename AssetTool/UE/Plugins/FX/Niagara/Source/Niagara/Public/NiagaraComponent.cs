namespace AssetTool
{
    [JsonAsset("NiagaraComponent")]
    public class UNiagaraComponent : UFXSystemComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}