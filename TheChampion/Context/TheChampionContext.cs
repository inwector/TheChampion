using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TheChampion.Context
{
    public partial class TheChampionContext : DbContext
    {
        public TheChampionContext()
        {
        }

        public TheChampionContext(DbContextOptions<TheChampionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<ChampionAbilities> ChampionAbilities { get; set; }
        public virtual DbSet<ChampionClasses> ChampionClasses { get; set; }
        public virtual DbSet<ChampionDuelLogs> ChampionDuelLogs { get; set; }
        public virtual DbSet<ChampionGender> ChampionGender { get; set; }
        public virtual DbSet<ChampionPassives> ChampionPassives { get; set; }
        public virtual DbSet<ChampionQuests> ChampionQuests { get; set; }
        public virtual DbSet<ChampionRaces> ChampionRaces { get; set; }
        public virtual DbSet<ChampionSkills> ChampionSkills { get; set; }
        public virtual DbSet<Champions> Champions { get; set; }
        public virtual DbSet<DamageTypes> DamageTypes { get; set; }
        public virtual DbSet<EnemyTypes> EnemyTypes { get; set; }
        public virtual DbSet<ItemProperties> ItemProperties { get; set; }
        public virtual DbSet<ItemRarities> ItemRarities { get; set; }
        public virtual DbSet<ItemSlots> ItemSlots { get; set; }
        public virtual DbSet<ItemTypes> ItemTypes { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Properties> Properties { get; set; }
        public virtual DbSet<QuestTypes> QuestTypes { get; set; }
        public virtual DbSet<Quests> Quests { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SkillTypes> SkillTypes { get; set; }

        // Unable to generate entity type for table 'dbo.ChampionQuestLogs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ChampionProperties'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ChampionRankings'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ChampionEquippedItems'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ARTIST168;Database=TheChampion;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PK__Accounts");

                entity.Property(e => e.AppleStoreId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FacebookId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GooglePlayId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionAbilities>(entity =>
            {
                entity.HasKey(e => e.AbilityId)
                    .HasName("PK__Abilitie__4248C43C09352018");

                entity.Property(e => e.Duration).HasColumnType("time(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionClasses>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK__Classes__CB1927C04FE344C9");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionDuelLogs>(entity =>
            {
                entity.HasKey(e => e.ChampionDuelLogId)
                    .HasName("PK__Champion__E5ACD80C9E2DCB0C");

                entity.Property(e => e.Damage).HasColumnType("decimal(9, 4)");
            });

            modelBuilder.Entity<ChampionGender>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .HasName("PK__Sex__75622D9604AFB469");

                entity.Property(e => e.GenderId).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionPassives>(entity =>
            {
                entity.HasKey(e => e.PassiveId)
                    .HasName("PK__Passives__89C472EF7C404A6C");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionQuests>(entity =>
            {
                entity.HasKey(e => e.ChampionQuestId)
                    .HasName("PK__Complete__ADBC140BDE7C26C3");

                entity.Property(e => e.QuestDate).HasColumnType("datetime");

                entity.HasOne(d => d.Champion)
                    .WithMany(p => p.ChampionQuests)
                    .HasForeignKey(d => d.ChampionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Completed__Champ__42ACE4D4");

                entity.HasOne(d => d.Quest)
                    .WithMany(p => p.ChampionQuests)
                    .HasForeignKey(d => d.QuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Completed__Quest__41B8C09B");
            });

            modelBuilder.Entity<ChampionRaces>(entity =>
            {
                entity.HasKey(e => e.RaceId)
                    .HasName("PK__Races__05FBD6B47E9FD9C5");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChampionSkills>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__Skills__DFA0918771C64010");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.SkillType)
                    .WithMany(p => p.ChampionSkills)
                    .HasForeignKey(d => d.SkillTypeId)
                    .HasConstraintName("FK__Skills__SkillTyp__38996AB5");
            });

            modelBuilder.Entity<Champions>(entity =>
            {
                entity.HasKey(e => e.ChampionId)
                    .HasName("PK__Champion__2C14F3238627D483");

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__Champion__A54720F8D383774D")
                    .IsUnique();

                entity.Property(e => e.Age).HasDefaultValueSql("((30))");

                entity.Property(e => e.GenderId)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Health).HasDefaultValueSql("((100))");

                entity.Property(e => e.Lvl).HasDefaultValueSql("((1))");

                entity.Property(e => e.Morale).HasDefaultValueSql("((50))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Stamina).HasDefaultValueSql("((100))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Champions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Champions__Accou__173876EA");
            });

            modelBuilder.Entity<DamageTypes>(entity =>
            {
                entity.HasKey(e => e.DamageTypeId)
                    .HasName("PK__DamageTy__8C5433730919C90C");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EnemyTypes>(entity =>
            {
                entity.HasKey(e => e.EnemyTypeId)
                    .HasName("PK__EnemyTyp__1D641631315F70D0");

                entity.Property(e => e.DamageTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.EnemyTypeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Speed).HasDefaultValueSql("((5))");

                entity.Property(e => e.WeaknessMultiplier).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ItemProperties>(entity =>
            {
                entity.HasKey(e => e.ItemPropertyId)
                    .HasName("PK__ItemProp__2E4BFEC229D986AD");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.ItemProperties)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ItemPrope__ItemT__17F790F9");
            });

            modelBuilder.Entity<ItemRarities>(entity =>
            {
                entity.HasKey(e => e.ItemRarityId)
                    .HasName("PK__ItemRari__C31656F9E9485BC0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemSlots>(entity =>
            {
                entity.HasKey(e => e.ItemSlotId)
                    .HasName("PK__ItemSlot__B56899DCF344CE5B");

                entity.Property(e => e.SlotName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemTypes>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId)
                    .HasName("PK__ItemType__F51540FB4B63E833");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemSlot)
                    .WithMany(p => p.ItemTypes)
                    .HasForeignKey(d => d.ItemSlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ItemTypes__ItemS__114A936A");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.ItemTypes)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ItemTypes__Corre__3B75D760");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Items__727E838B0FCE807D");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ItemRarity)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemRarityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Items__ItemRarit__571DF1D5");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.ItemTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Items__ItemTypeI__5629CD9C");
            });

            modelBuilder.Entity<Properties>(entity =>
            {
                entity.HasKey(e => e.PropertyId)
                    .HasName("PK__Properti__70C9A735A9F4767C");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Suffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QuestTypes>(entity =>
            {
                entity.HasKey(e => e.QuestTypeId)
                    .HasName("PK__QuestTyp__08DB688C71B93251");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quests>(entity =>
            {
                entity.HasKey(e => e.QuestId)
                    .HasName("PK__Quests__B6619A2B84A45E59");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.QuestType)
                    .WithMany(p => p.Quests)
                    .HasForeignKey(d => d.QuestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Quests__QuestTyp__619B8048");
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => e.SettingCode);

                entity.Property(e => e.SettingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SkillTypes>(entity =>
            {
                entity.HasKey(e => e.SkillTypeId)
                    .HasName("PK__SkillTyp__8FB2F9FAC972E3F1");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
        }
    }
}
