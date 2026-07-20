CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    migration_id character varying(150) NOT NULL,
    product_version character varying(32) NOT NULL,
    CONSTRAINT pk___ef_migrations_history PRIMARY KEY (migration_id)
);

START TRANSACTION;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "migration_id" = '20260613125342_InitialCreate') THEN
    CREATE TABLE clinic_profiles (
        id uuid NOT NULL,
        business_id uuid NOT NULL,
        name text NOT NULL,
        phone_number text NOT NULL,
        address text NOT NULL,
        slug text NOT NULL,
        status text NOT NULL,
        opening_hours text NOT NULL,
        animals_seen text NOT NULL,
        created_at timestamp with time zone NOT NULL,
        CONSTRAINT pk_clinic_profiles PRIMARY KEY (id)
    );
    END IF;
END $EF$;

DO $EF$
BEGIN
    IF NOT EXISTS(SELECT 1 FROM "__EFMigrationsHistory" WHERE "migration_id" = '20260613125342_InitialCreate') THEN
    INSERT INTO "__EFMigrationsHistory" (migration_id, product_version)
    VALUES ('20260613125342_InitialCreate', '10.0.9');
    END IF;
END $EF$;
COMMIT;

