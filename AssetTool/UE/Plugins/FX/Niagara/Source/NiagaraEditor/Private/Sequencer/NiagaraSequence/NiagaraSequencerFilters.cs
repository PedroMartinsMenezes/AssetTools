namespace AssetTool
{
    [JsonAsset("NiagaraSequencerTrackFilter")]
    public class UNiagaraSequencerTrackFilter : USequencerTrackFilterExtension
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}