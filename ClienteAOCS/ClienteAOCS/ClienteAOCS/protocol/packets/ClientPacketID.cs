﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClienteAOCS.protocol.packets
{
    public enum ClientPacketID : byte
    {
        LoginExistingChar,
        ThrowDices ,
        LoginNewChar,
        Talk,
        Yell,
        Whisper,
        Walk,
        RequestPositionUpdate,
        Attack,
        PickUp,
        SafeToggle,
        ResuscitationSafeToggle,
        RequestGuildLeaderInfo,
        RequestAtributes,
        RequestFame,
        RequestSkills,
        RequestMiniStats,
        CommerceEnd,
        UserCommerceEnd,
        UserCommerceConfirm,
        CommerceChat,
        BankEnd,
        UserCommerceOk,
        UserCommerceReject,
        Drop,
        CastSpell,
        LeftClick,
        DoubleClick,
        Work,
        UseSpellMacro,
        UseItem,
        CraftBlacksmith,
        CraftCarpenter,
        WorkLeftClick,
        CreateNewGuild,
        SpellInfo,
        EquipItem,
        ChangeHeading,
        ModifySkills,
        Train,
        CommerceBuy,
        BankExtractItem,
        CommerceSell,
        BankDeposit,
        ForumPost,
        MoveSpell,
        MoveBank,
        ClanCodexUpdate,
        UserCommerceOffer,
        GuildAcceptPeace,
        GuildRejectAlliance,
        GuildRejectPeace,
        GuildAcceptAlliance,
        GuildOfferPeace,
        GuildOfferAlliance,
        GuildAllianceDetails,
        GuildPeaceDetails,
        GuildRequestJoinerInfo,
        GuildAlliancePropList,
        GuildPeacePropList,
        GuildDeclareWar,
        GuildNewWebsite,
        GuildAcceptNewMember,
        GuildRejectNewMember,
        GuildKickMember,
        GuildUpdateNews,
        GuildMemberInfo,
        GuildOpenElections,
        GuildRequestMembership,
        GuildRequestDetails,
        Online,
        Quit,
        GuildLeave,
        RequestAccountState,
        PetStand,
        PetFollow,
        ReleasePet,
        TrainList,
        Rest,
        Meditate,
        Resucitate,
        Heal,
        Help,
        RequestStats,
        CommerceStart,
        BankStart,
        Enlist,
        Information,
        Reward,
        RequestMOTD,
        Uptime,
        PartyLeave,
        PartyCreate,
        PartyJoin,
        Inquiry,
        GuildMessage,
        PartyMessage,
        CentinelReport,
        GuildOnline,
        PartyOnline,
        CouncilMessage,
        RoleMasterRequest,
        GMRequest,
        bugReport,
        ChangeDescription,
        GuildVote,
        Punishments,
        ChangePassword,
        Gamble,
        InquiryVote,
        LeaveFaction,
        BankExtractGold,
        BankDepositGold,
        Denounce,
        GuildFundate,
        GuildFundation,
        PartyKick,
        PartySetLeader,
        PartyAcceptMember,
        Ping,
        RequestPartyForm,
        ItemUpgrade,
        GMCommands,
        InitCrafting,
        Home,
        ShowGuildNews,
        ShareNpc,
        StopSharingNpc,
        Consultation,
        MoveItem,
        RightClick,
        PMDeleteList,
        PMList
    }
}
