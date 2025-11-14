namespace AssetTool
{
    [JsonAsset("NiagaraDataInterfaceActorComponent")]
    public class UNiagaraDataInterfaceActorComponent : UNiagaraDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}