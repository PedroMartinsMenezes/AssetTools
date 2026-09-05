
namespace AssetTool
{
    public class FSpeedTreeWind : ITransferable
    {
        public float m_fStrengthResponse;
        public float m_fDirectionResponse;
        public float m_fAnchorOffset;
        public float m_fAnchorDistanceScale;
        public float[][] m_afFrequencies;
        public float m_fGlobalHeight;
        public float m_fGlobalHeightExponent;
        public float[] m_afGlobalDistance = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
        public float[] m_afGlobalDirectionAdherence = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
        public SBranchWindLevel[] m_asBranch = ((int)Constants.NUM_BRANCH_LEVELS).ToArray<SBranchWindLevel>();
        public SWindGroup[] m_asLeaf = ((int)Constants.NUM_LEAF_GROUPS).ToArray<SWindGroup>();
        public float[] m_afFrondRippleDistance = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
        public float m_fFrondRippleTile;
        public float m_fFrondRippleLightingScalar;
        public float m_fRollingNoiseSize;
        public float m_fRollingNoiseTwist;
        public float m_fRollingNoiseTurbulence;
        public float m_fRollingNoisePeriod;
        public float m_fRollingNoiseSpeed;
        public float m_fRollingBranchFieldMin;
        public float m_fRollingBranchLightingAdjust;
        public float m_fRollingBranchVerticalOffset;
        public float m_fRollingLeafRippleMin;
        public float m_fRollingLeafTumbleMin;
        public float m_fGustFrequency;
        public float m_fGustStrengthMin;
        public float m_fGustStrengthMax;
        public float m_fGustDurationMin;
        public float m_fGustDurationMax;
        public float m_fGustRiseScalar;
        public float m_fGustFallScalar;
        public bool[] Options = new bool[(int)EOptions.NUM_WIND_OPTIONS];
        public FVector BranchAnchor;
        public float MaxBranchLength;

        public FSpeedTreeWind()
        {
            if (m_afFrequencies == default)
            {
                m_afFrequencies = new float[(int)EOscillationComponents.NUM_OSC_COMPONENTS][];
                for (int i = 0; i < m_afFrequencies.Length; i++)
                {
                    m_afFrequencies[i] = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
                }
            }
        }

        [Location("FArchive& operator<<(FArchive& Ar, FSpeedTreeWind& Wind)")]
        public ITransferable Move(Transfer transfer)
        {
            transfer.Move(ref m_fStrengthResponse);
            transfer.Move(ref m_fDirectionResponse);
            transfer.Move(ref m_fAnchorOffset);
            transfer.Move(ref m_fAnchorDistanceScale);

            for (int32 OscIndex = 0; OscIndex < (int)EOscillationComponents.NUM_OSC_COMPONENTS; ++OscIndex)
            {
                for (int32 CurveIndex = 0; CurveIndex < (int)Constants.NUM_WIND_POINTS_IN_CURVE; ++CurveIndex)
                {
                    transfer.Move(ref m_afFrequencies[OscIndex][CurveIndex]);
                }
            }

            transfer.Move(ref m_fGlobalHeight);
            transfer.Move(ref m_fGlobalHeightExponent);
            transfer.Move(ref m_afGlobalDistance, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
            transfer.Move(ref m_afGlobalDirectionAdherence, (int)Constants.NUM_WIND_POINTS_IN_CURVE);

            for (int32 BranchIndex = 0; BranchIndex < (int)Constants.NUM_BRANCH_LEVELS; ++BranchIndex)
            {
                transfer.Move(ref m_asBranch[BranchIndex].m_afDistance, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asBranch[BranchIndex].m_afDirectionAdherence, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asBranch[BranchIndex].m_afWhip, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asBranch[BranchIndex].m_fTurbulence);
                transfer.Move(ref m_asBranch[BranchIndex].m_fTwitch);
                transfer.Move(ref m_asBranch[BranchIndex].m_fTwitchFreqScale);
            }

            if (!transfer.Supports.VER_UE4_SPEEDTREE_WIND_V7)
            {
                float fDiscardOldRolling = 0.0f;
                transfer.Move(ref fDiscardOldRolling);
                transfer.Move(ref fDiscardOldRolling);
                transfer.Move(ref fDiscardOldRolling);
                transfer.Move(ref fDiscardOldRolling);
            }

            for (int32 LeafIndex = 0; LeafIndex < (int)Constants.NUM_LEAF_GROUPS; ++LeafIndex)
            {
                transfer.Move(ref m_asLeaf[LeafIndex].m_afRippleDistance, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asLeaf[LeafIndex].m_afTumbleFlip, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asLeaf[LeafIndex].m_afTumbleTwist, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asLeaf[LeafIndex].m_afTumbleDirectionAdherence, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asLeaf[LeafIndex].m_afTwitchThrow, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
                transfer.Move(ref m_asLeaf[LeafIndex].m_fTwitchSharpness);
                transfer.Move(ref m_asLeaf[LeafIndex].m_fRollMaxScale);
                transfer.Move(ref m_asLeaf[LeafIndex].m_fRollMinScale);
                transfer.Move(ref m_asLeaf[LeafIndex].m_fRollSpeed);
                transfer.Move(ref m_asLeaf[LeafIndex].m_fRollSeparation);
                transfer.Move(ref m_asLeaf[LeafIndex].m_fLeewardScalar);
            }

            transfer.Move(ref m_afFrondRippleDistance, (int)Constants.NUM_WIND_POINTS_IN_CURVE);
            transfer.Move(ref m_fFrondRippleTile);
            transfer.Move(ref m_fFrondRippleLightingScalar);

            if (transfer.Supports.VER_UE4_SPEEDTREE_WIND_V7)
            {
                transfer.Move(ref m_fRollingNoiseSize);
                transfer.Move(ref m_fRollingNoiseTwist);
                transfer.Move(ref m_fRollingNoiseTurbulence);
                transfer.Move(ref m_fRollingNoisePeriod);
                transfer.Move(ref m_fRollingNoiseSpeed);
                transfer.Move(ref m_fRollingBranchFieldMin);
                transfer.Move(ref m_fRollingBranchLightingAdjust);
                transfer.Move(ref m_fRollingBranchVerticalOffset);
                transfer.Move(ref m_fRollingLeafRippleMin);
                transfer.Move(ref m_fRollingLeafTumbleMin);
            }

            transfer.Move(ref m_fGustFrequency);
            transfer.Move(ref m_fGustStrengthMin);
            transfer.Move(ref m_fGustStrengthMax);
            transfer.Move(ref m_fGustDurationMin);
            transfer.Move(ref m_fGustDurationMax);
            transfer.Move(ref m_fGustRiseScalar);
            transfer.Move(ref m_fGustFallScalar);

            SERIALIZE_OPTION(transfer, EOptions.GLOBAL_WIND);
            SERIALIZE_OPTION(transfer, EOptions.GLOBAL_PRESERVE_SHAPE);

            SERIALIZE_OPTION(transfer, EOptions.BRANCH_SIMPLE_1);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_DIRECTIONAL_1);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_DIRECTIONAL_FROND_1);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_TURBULENCE_1);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_WHIP_1);
            SKIP_OLD_OPTION(transfer);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_OSC_COMPLEX_1);

            SERIALIZE_OPTION(transfer, EOptions.BRANCH_SIMPLE_2);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_DIRECTIONAL_2);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_DIRECTIONAL_FROND_2);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_TURBULENCE_2);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_WHIP_2);
            SKIP_OLD_OPTION(transfer);
            SERIALIZE_OPTION(transfer, EOptions.BRANCH_OSC_COMPLEX_2);

            SERIALIZE_OPTION(transfer, EOptions.LEAF_RIPPLE_VERTEX_NORMAL_1);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_RIPPLE_COMPUTED_1);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_TUMBLE_1);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_TWITCH_1);
            SKIP_OLD_OPTION(transfer);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_OCCLUSION_1);

            SERIALIZE_OPTION(transfer, EOptions.LEAF_RIPPLE_VERTEX_NORMAL_2);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_RIPPLE_COMPUTED_2);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_TUMBLE_2);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_TWITCH_2);
            SKIP_OLD_OPTION(transfer);
            SERIALIZE_OPTION(transfer, EOptions.LEAF_OCCLUSION_2);

            SERIALIZE_OPTION(transfer, EOptions.FROND_RIPPLE_ONE_SIDED);
            SERIALIZE_OPTION(transfer, EOptions.FROND_RIPPLE_TWO_SIDED);
            SERIALIZE_OPTION(transfer, EOptions.FROND_RIPPLE_ADJUST_LIGHTING);

            if (transfer.Supports.VER_UE4_SPEEDTREE_WIND_V7)
            {
                SERIALIZE_OPTION(transfer, EOptions.ROLLING);
            }

            transfer.Move(ref BranchAnchor);
            transfer.Move(ref MaxBranchLength);

            return this;
        }

        private void SERIALIZE_OPTION(Transfer transfer, EOptions option)
        {
            transfer.Move(ref Options[(int)option]);
        }

        private static void SKIP_OLD_OPTION(Transfer transfer)
        {
            if (!transfer.Supports.VER_UE4_SPEEDTREE_WIND_V7)
            {
                bool bDiscard = false;
                transfer.Move(ref bDiscard);
            }
        }

        public class SBranchWindLevel
        {
            public float[] m_afDistance = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float[] m_afDirectionAdherence = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float[] m_afWhip = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float m_fTurbulence;
            public float m_fTwitch;
            public float m_fTwitchFreqScale;
        }

        public class SWindGroup
        {
            public float[] m_afRippleDistance = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float[] m_afTumbleFlip = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float[] m_afTumbleTwist = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float[] m_afTumbleDirectionAdherence = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float[] m_afTwitchThrow = new float[(int)Constants.NUM_WIND_POINTS_IN_CURVE];
            public float m_fTwitchSharpness;
            public float m_fRollMaxScale;
            public float m_fRollMinScale;
            public float m_fRollSpeed;
            public float m_fRollSeparation;
            public float m_fLeewardScalar;
        };

        enum EOscillationComponents
        {
            OSC_GLOBAL,
            OSC_BRANCH_1,
            OSC_BRANCH_2,
            OSC_LEAF_1_RIPPLE,
            OSC_LEAF_1_TUMBLE,
            OSC_LEAF_1_TWITCH,
            OSC_LEAF_2_RIPPLE,
            OSC_LEAF_2_TUMBLE,
            OSC_LEAF_2_TWITCH,
            OSC_FROND_RIPPLE,
            NUM_OSC_COMPONENTS
        }

        enum Constants
        {
            NUM_WIND_POINTS_IN_CURVE = 10,
            NUM_BRANCH_LEVELS = 2,
            NUM_LEAF_GROUPS = 2
        }

        enum EOptions
        {
            GLOBAL_WIND,
            GLOBAL_PRESERVE_SHAPE,

            BRANCH_SIMPLE_1,
            BRANCH_DIRECTIONAL_1,
            BRANCH_DIRECTIONAL_FROND_1,
            BRANCH_TURBULENCE_1,
            BRANCH_WHIP_1,
            BRANCH_OSC_COMPLEX_1,

            BRANCH_SIMPLE_2,
            BRANCH_DIRECTIONAL_2,
            BRANCH_DIRECTIONAL_FROND_2,
            BRANCH_TURBULENCE_2,
            BRANCH_WHIP_2,
            BRANCH_OSC_COMPLEX_2,

            LEAF_RIPPLE_VERTEX_NORMAL_1,
            LEAF_RIPPLE_COMPUTED_1,
            LEAF_TUMBLE_1,
            LEAF_TWITCH_1,
            LEAF_OCCLUSION_1,

            LEAF_RIPPLE_VERTEX_NORMAL_2,
            LEAF_RIPPLE_COMPUTED_2,
            LEAF_TUMBLE_2,
            LEAF_TWITCH_2,
            LEAF_OCCLUSION_2,

            FROND_RIPPLE_ONE_SIDED,
            FROND_RIPPLE_TWO_SIDED,
            FROND_RIPPLE_ADJUST_LIGHTING,

            ROLLING,

            NUM_WIND_OPTIONS
        }
    }
}
