PGDMP  2                    }            AgendaDB    17.4    17.4                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false                        0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            !           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            "           1262    16387    AgendaDB    DATABASE     p   CREATE DATABASE "AgendaDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'pt-BR';
    DROP DATABASE "AgendaDB";
                     postgres    false            �            1259    16389    contato    TABLE     0  CREATE TABLE public.contato (
    id integer NOT NULL,
    nome character varying(100),
    apelido character varying(100),
    cpf character varying(14),
    telefone character varying(15),
    email character varying(100),
    data_cadastro date DEFAULT CURRENT_DATE,
    data_ultima_alteracao date
);
    DROP TABLE public.contato;
       public         heap r       postgres    false            �            1259    16388    contato_id_seq    SEQUENCE     �   CREATE SEQUENCE public.contato_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 %   DROP SEQUENCE public.contato_id_seq;
       public               postgres    false    218            #           0    0    contato_id_seq    SEQUENCE OWNED BY     A   ALTER SEQUENCE public.contato_id_seq OWNED BY public.contato.id;
          public               postgres    false    217            �           2604    16392 
   contato id    DEFAULT     h   ALTER TABLE ONLY public.contato ALTER COLUMN id SET DEFAULT nextval('public.contato_id_seq'::regclass);
 9   ALTER TABLE public.contato ALTER COLUMN id DROP DEFAULT;
       public               postgres    false    217    218    218                      0    16389    contato 
   TABLE DATA           p   COPY public.contato (id, nome, apelido, cpf, telefone, email, data_cadastro, data_ultima_alteracao) FROM stdin;
    public               postgres    false    218   ~       $           0    0    contato_id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public.contato_id_seq', 4, true);
          public               postgres    false    217            �           2606    16395    contato contato_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.contato
    ADD CONSTRAINT contato_pkey PRIMARY KEY (id);
 >   ALTER TABLE ONLY public.contato DROP CONSTRAINT contato_pkey;
       public                 postgres    false    218               g   x�3�,NLI,�L,�)��F�:P�khĩah��`���HmJb�Cznbf�^r~.����������!�ih�e3l6���h��Ղ��I��F�lf� ��)     